<script setup>
  import { ref, reactive, onMounted } from 'vue';
  import { useAuthStore } from '../auth.js';
  import apiClient from '../axios.js';
  import { useRouter } from 'vue-router';
  import { decodeToken } from '../auth.js';
  // Работа с хранилищем и маршрутизацией
  const authStore = useAuthStore();
  const router = useRouter();

  // Данные пользователя
  const user = reactive({
    name: '',
    lastName: '',
    email: '',
  });

  // Флаги состояния
  const isLoading = ref(false);
  const errorMessage = ref('');
  const isEditing = ref(false); // Режим редактирования

  // Функция загрузки данных о пользователе
  const fetchUserData = async () => {
    try {
      isLoading.value = true;
      errorMessage.value = '';

      // Проверяем, есть ли токен в хранилище
      if (!authStore.token) {
        throw new Error('Токен отсутствует');
      }

      // Извлекаем логин из токена
      const decodedToken = decodeToken(authStore.token);
      console.log(decodedToken);
      const userLogin = decodedToken["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];

      if (!userLogin) {
        throw new Error('Не удалось получить логин из токена');
      }

      // Запрашиваем данные пользователя с использованием логина
      const response = await apiClient.get(`/users/login/${userLogin}`);
      Object.assign(user, response.data); // Обновляем данные пользователя
    } catch (error) {
      console.error('Ошибка при загрузке данных пользователя:', error);
      errorMessage.value = error.message || 'Не удалось загрузить данные пользователя.';
    } finally {
      isLoading.value = false;
    }
  };

  // Функция сохранения изменений
  const saveUserData = async () => {
    try {
      isLoading.value = true;
      errorMessage.value = '';

      // Получаем логин из токена
      const decodedToken = decodeToken(authStore.token);
      console.log(decodedToken);
      const userLogin = decodedToken["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"];


      if (!userLogin) {
        throw new Error('Не удалось получить логин из токена');
      }

      // Делаем PUT-запрос для обновления данных
      await apiClient.put(`/users/login/${userLogin}`, {
        name: user.name,
        lastname: user.lastName,
      });

      isEditing.value = false; // Выходим из режима редактирования
    } catch (error) {
      console.error('Ошибка при сохранении данных пользователя:', error);
      errorMessage.value = 'Не удалось сохранить данные пользователя.';
    } finally {
      isLoading.value = false;
    }
  };

  // Загрузка данных после монтирования компонента
  onMounted(() => {
    if (!authStore.isAuthenticated) {
      router.push('/login'); 
    } else {
      fetchUserData();
    }
  });
</script>

<template>
  <div class="container">
    <div class="section-header">
      <h1>Профиль пользователя</h1>
    </div>

    <!-- Отображение состояния загрузки -->
    <div v-if="isLoading" class="loading">Загрузка...</div>

    <!-- Отображение ошибок -->
    <div v-if="errorMessage" class="error-message">{{ errorMessage }}</div>

    <!-- Отображение данных пользователя -->
    <div v-else class="profile-content">
      <!-- Режим просмотра -->
      <div v-if="!isEditing">
        <p>Имя: {{ user.name }}</p>
        <p>Фамилия: {{ user.lastName }}</p>
        <p>Email: {{ user.email }}</p>
        

        <button @click="isEditing = true" class="edit-button">Редактировать</button>
      </div>

      <!-- Режим редактирования -->
      <div v-else>
        <div class="form-group">
          <label for="name">Имя:</label>
          <input id="name" v-model="user.name" type="text" />
        </div>
        <div class="form-group">
          <label for="lastname">Фамилия:</label>
          <input id="lastname" v-model="user.lastName" type="text" />
        </div>

        <button @click="saveUserData" class="save-button">Сохранить</button>
        <button @click="isEditing = false" class="cancel-button">Отмена</button>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .container {
    display: flex;
    flex-direction: column;
    align-items: left;
    padding: 20px;
  }

  .section-header {
    background-color: #4CAF50;
    color: white;
    padding: 15px 20px;
    border-radius: 5px;
    margin-bottom: 20px;
    width: 100%;
  }

  .loading {
    font-size: 18px;
    color: #555;
  }

  .error-message {
    color: red;
    font-weight: bold;
  }

  .profile-content {
    width: 100%;
    max-width: 500px;
    background: #f9f9f9;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  }

  .form-group {
    margin-bottom: 15px;
  }

    .form-group label {
      display: block;
      font-weight: bold;
      margin-bottom: 5px;
    }

    .form-group input {
      width: 100%;
      padding: 8px;
      border: 1px solid #ccc;
      border-radius: 4px;
    }

  .edit-button,
  .save-button,
  .cancel-button {
    padding: 10px 15px;
    margin-top: 10px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
  }

  .edit-button {
    background-color: white;
    border: 2px solid black;
    color: black;
    padding: 10px 20px;
    font-size: 13px;
    cursor: pointer;
    display: flex;
    align-items: center;
    gap: 10px;
    border-radius: 5px;
    transition: background-color 0.3s, color 0.3s;
  }

    .edit-button:hover {
      background-color: black;
      color: white;
    }


  .save-button {
    background-color: white;
    border: 2px solid green;
    color: green;
    padding: 10px 20px;
    font-size: 13px;
    cursor: pointer;
    display: inline-flex;
    align-items: center;
    gap: 10px;
    border-radius: 5px;
    transition: background-color 0.3s, color 0.3s;
  }

    .save-button:hover {
      background-color: green;
      color: white;
    }

  /* Кнопка отмены */
  .cancel-button {
    background-color: white;
    border: 2px solid red;
    color: red;
    padding: 10px 20px;
    font-size: 13px;
    cursor: pointer;
    display: inline-flex;
    align-items: center;
    gap: 10px;
    border-radius: 5px;
    transition: background-color 0.3s, color 0.3s;
    margin-left: 5px;
  }

    .cancel-button:hover {
      background-color: red;
      color: white;
    }
</style>
