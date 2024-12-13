<script>
  import { ref } from 'vue';
  import Card from 'primevue/card';
  import InputText from 'primevue/inputtext';
  import Password from 'primevue/password';
  import Button from 'primevue/button';
  import { useRouter } from 'vue-router';
  import { useAuthStore } from '../auth.js';

  export default {
    name: 'RegistrationView',
    components: {
      Card,
      InputText,
      Password,
      Button
    },
    setup() {
      const username = ref('');
      const email = ref('');
      const password = ref('');
      const name = ref('');
      const lastName = ref('');
      const router = useRouter();
      const authStore = useAuthStore();
      const errors = ref({
        username: '',
        email: '',
        password: '',
        name: '',
        lastName: ''
      });

      const validateForm = () => {
        
        errors.value = {
          username: '',
          email: '',
          password: '',
          name: '',
          lastName: ''
        };

        let isValid = true;

        
        if (!username.value) {
          errors.value.username = 'Поле "Никнейм" не может быть пустым.';
          isValid = false;
        }
        if (!name.value) {
          errors.value.name = 'Поле "Имя" не может быть пустым.';
          
          isValid = false;

        }
        if (!lastName.value) {
          errors.value.lastName = 'Поле "Фамилия" не может быть пустым.';
          isValid = false;
        }
        if (!email.value) {
          errors.value.email = 'Поле "Email" не может быть пустым.';
          isValid = false;
        } else if (!/\S+@\S+\.\S+/.test(email.value)) {  
          errors.value.email = 'Неверный формат email.';
          isValid = false;
        }
        if (!password.value) {
          errors.value.password = 'Поле "Пароль" не может быть пустым.';
          isValid = false;
        } else if (!/[a-zA-Z]/.test(password.value)) {  
          errors.value.password = 'Пароль должен содержать хотя бы одну букву.';
          isValid = false;
        }

        return isValid;
      };

      const signUp = async () => {
        if (validateForm()) {
          try {
            await authStore.register({
              username: username.value,
              name: name.value,
              lastName: lastName.value,
              email: email.value,
              password: password.value
            });
            router.push('/');
          } catch (error) {
            console.error('Ошибка регистрации:', error);
          }
        }
      };

      return { username, email, password, name, lastName, signUp, errors };
    }
  };
</script>

<template>
  <Card>
    <template #title>
      <div class="centered-title">Регистрация</div>
    </template>
    <template #content>
      <div class="p-field">
        <label for="name">Ваше имя</label>
        <InputText id="name" v-model="name" />
        <small v-if="errors.name" class="p-error">{{ errors.name }}</small>
      </div>
      <div class="p-field">
        <label for="lastName">Ваша фамилия</label>
        <InputText id="lastName" v-model="lastName" />
        <small v-if="errors.lastName" class="p-error">{{ errors.lastName }}</small>
      </div>
      <div class="p-field">
        <label for="username">Ваш никнейм</label>
        <InputText id="username" v-model="username" />
        <small v-if="errors.username" class="p-error">{{ errors.username }}</small>
      </div>
      <div class="p-field">
        <label for="email">Email</label>
        <InputText id="email" v-model="email" />
        <small v-if="errors.email" class="p-error">{{ errors.email }}</small>
      </div>
      <div class="p-field">
        <label for="password">Пароль</label>
        <Password id="password" v-model="password" />
        <small v-if="errors.password" class="p-error">{{ errors.password }}</small>
      </div>
    </template>
    <template #footer>
      <Button label="Зарегистрироваться" icon="pi pi-check" @click="signUp" />
    </template>
  </Card>
</template>

<style scoped>
  .registration-form {
    max-width: 400px;
    margin: 0 auto;
    padding: 20px;
    background: #fff;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    border-radius: 5px;
  }

  .p-field {
    margin-bottom: 15px;
  }

    .p-field label {
      display: block;
      margin-bottom: 5px;
      font-weight: bold;
    }

  .centered-title {
    text-align: center;
    font-size: 1.5em;
    font-weight: bold;
  }

  .p-error {
    color: red;
    font-size: 0.875rem;
  }
</style>
