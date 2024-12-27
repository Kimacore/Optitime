<script setup>
  import { ref, onMounted } from 'vue';
  import DataTable from 'primevue/datatable';
  import Column from 'primevue/column';
  import Button from 'primevue/button';
  import Dialog from 'primevue/dialog';
  import InputText from 'primevue/inputtext';
  import Calendar from 'primevue/calendar';
  import Dropdown from 'primevue/dropdown';

  import { useAuthStore } from '../auth.js';
  import apiClient from '../axios.js';
  import { decodeToken } from '../auth.js';

  const projects = ref([]);
  const isLoading = ref(true);
  const errorMessage = ref('');
  const showAddDialog = ref(false);
  const newProject = ref({
    name: '',
    description: '',
    startDate: null,
    endDate: null,
    status: null,
  });

  const statuses = ref([
    { label: 'В работе', value: 'In Progress' },
    { label: 'Завершен', value: 'Completed' },
  ]);

  const authStore = useAuthStore();

  const fetchProjects = async () => {
    try {
      isLoading.value = true;
      errorMessage.value = '';

      if (!authStore.token) {
        throw new Error('Токен отсутствует. Пожалуйста, войдите в систему.');
      }

      const decodedToken = decodeToken(authStore.token);
      const userId = decodedToken['id'];

      if (!userId) {
        throw new Error('Не удалось извлечь ID пользователя из токена.');
      }

      const response = await apiClient.get(`/projects/${userId}`);
      projects.value = response.data;
      console.log(projects.value[0].id)
    } catch (error) {
      console.error('Ошибка при загрузке проектов:', error);
      
    } finally {
      isLoading.value = false;
    }
  };

  const getStatusLabel = (statusValue) => {
    const status = statuses.value.find((s) => s.value === statusValue);
    return status ? status.label : ''; 
  };

  const openAddProjectModal = () => {
    showAddDialog.value = true;
  };

  const closeAddProjectModal = () => {
    showAddDialog.value = false;

    
    Object.keys(newProject.value).forEach((key) => (newProject.value[key] = ''));
  };

  const addProject = async () => {
    try {
      const decodedToken = decodeToken(authStore.token);
      const ownerId = decodedToken['id'];

      if (!ownerId) {
        throw new Error('Не удалось извлечь ID пользователя.');
      }

      const projectToAdd = {
        name: newProject.value.name,
        description: newProject.value.description,
        startDate: newProject.value.startDate
          ? newProject.value.startDate.toISOString()
          : null,
        endDate: newProject.value.endDate
          ? newProject.value.endDate.toISOString()
          : null,
        status: newProject.value.status ? newProject.value.status.label : null,
        ownerId: ownerId,
      };

      const response = await apiClient.post('/projects/create', projectToAdd);

      projects.value.push(response.data);

      closeAddProjectModal();
      Object.keys(newProject.value).forEach((key) => (newProject.value[key] = ''));
    } catch (error) {
      console.error('Ошибка при добавлении проекта:', error);
      errorMessage.value = error.message || 'Не удалось добавить проект.';
    }
  };

  const deleteProject = async (index) => {
    if (projects.value.length === 0) {
      return;
    }
    try {
      
      const project = projects.value[index];
      const projectId = project.id;

      console.log('Удаление проекта с id:', projectId);

     
      const response = await apiClient.delete(`/projects/delete/${projectId}`);

      
      projects.value.splice(index, 1); 
    } catch (error) {
      console.error('Ошибка при удалении проекта:', error);
      errorMessage.value = error.message || 'Не удалось удалить проект.';
    }
  };

  onMounted(() => {
    fetchProjects();
  });
</script>

<template>
  <div class="container">
    <div class="main-content">
      <div class="section-header">
        <h1>Проекты</h1>
        <Button label="Добавить проект"
                class="add-project-button"
                icon="pi pi-plus"
                iconPos="left"
                @click="openAddProjectModal" />
      </div>
      <div class="profile-content">
        <template v-if="isLoading">
          <p>Загрузка проектов...</p>
        </template>
        <template v-else>
          <DataTable :value="projects"
                     class="custom-table"
                     :emptyMessage="'Нет доступных проектов.'">
            <Column field="name"
                    header="Название"
                    sortable
                    style="width: 20%"></Column>
            <Column field="description"
                    header="Описание"
                    sortable
                    style="width: 30%"></Column>
            <Column field="startDate"
                    header="Начало работы"
                    sortable
                    style="width: 15%"></Column>
            <Column field="endDate"
                    header="Конец"
                    sortable
                    style="width: 15%"></Column>
            <Column field="status"
                    header="Статус"
                    :body="(rowData) => getStatusLabel(rowData.status)"
                    sortable
                    style="width: 20%" />
            <Column header="Удалить" style="width: 10%">
              <template #body="{ rowData, index }">
                <Button icon="pi pi-trash" class="p-button-danger" @click="deleteProject(index)" />
              </template>
            </Column>
          </DataTable>
          <p v-if="errorMessage" class="error">{{ errorMessage }}</p>
        </template>
      </div>
    </div>

    <Dialog header="Добавить проект"
            :visible.sync="showAddDialog"
            modal
            class="add-project-dialog"
            @hide="closeAddProjectModal">
      <div class="form-group">
        <label>Название</label>
        <InputText v-model="newProject.name" placeholder="Введите название" />
      </div>
      <div class="form-group">
        <label>Описание</label>
        <InputText v-model="newProject.description" placeholder="Введите описание" />
      </div>
      <div class="form-group">
        <label>Начало работы</label>
        <Calendar v-model="newProject.startDate" />
      </div>
      <div class="form-group">
        <label>Конец</label>
        <Calendar v-model="newProject.endDate" />
      </div>
      <div class="form-group">
        <label>Статус</label>
        <Dropdown v-model="newProject.status"
                  :options="statuses"
                  optionLabel="label"
                  placeholder="Выберите статус" />
      </div>
      <div class="dialog-actions">
        <Button label="Отмена" class="p-button-text" @click="closeAddProjectModal" />
        <Button label="Сохранить" class="p-button-primary" @click="addProject" />
      </div>
    </Dialog>
  </div>
</template>

<style scoped>
  .section-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: #4caf50;
    color: white;
    padding: 15px 20px;
    border-radius: 5px;
    margin-bottom: 20px;
  }

  .add-project-button .pi {
    margin-right: 0.5rem;
  }

  .dialog-actions {
    display: flex;
    justify-content: flex-end;
    gap: 1rem;
    margin-top: 1rem;
  }

  .add-project-dialog .form-group {
    display: flex;
    flex-direction: column;
    margin-bottom: 1.5rem;
  }

  .add-project-dialog label {
    margin-bottom: 0.5rem;
  }

  .custom-table {
    width: 100%; 
  }

    .custom-table .p-datatable-tbody > tr {
      display: block;
      width: 100%; 
    }

      .custom-table .p-datatable-tbody > tr > td {
        width: auto; 
        padding: 8px;
      }

  .p-datatable .p-datatable-header {
    display: none; 
  }
</style>
