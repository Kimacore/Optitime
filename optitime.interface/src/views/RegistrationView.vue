<script setup>
  import { ref } from 'vue';
  import Card from 'primevue/card';
  import InputText from 'primevue/inputtext';
  import Password from 'primevue/password';
  import Button from 'primevue/button';
  import { useRouter } from 'vue-router';
  import { useAuthStore } from '../auth.js';

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

  const clearError = (field) => {
    errors.value[field] = ''; // Очистка ошибки для указанного поля
  };

  const validateForm = () => {
    errors.value = {
      username: '',
      email: '',
      password: '',
      name: '',
      lastName: ''
    };

    let isValid = true;

    // Имя: только буквы, минимум 2 символа, без цифр
    if (!name.value) {
      errors.value.name = 'Поле "Имя" не может быть пустым.';
      isValid = false;
    } else if (!/^[a-zA-Zа-яА-Я]{2,}$/.test(name.value)) {
      errors.value.name = 'Имя должно содержать только буквы и быть не менее 2 символов.';
      isValid = false;
    }

    // Фамилия: только буквы, минимум 2 символа, без цифр
    if (!lastName.value) {
      errors.value.lastName = 'Поле "Фамилия" не может быть пустым.';
      isValid = false;
    } else if (!/^[a-zA-Zа-яА-Я]{2,}$/.test(lastName.value)) {
      errors.value.lastName = 'Фамилия должна содержать только буквы и быть не менее 2 символов.';
      isValid = false;
    }

    // Никнейм: минимум 3 символа, только буквы, без спецсимволов
    if (!username.value) {
      errors.value.username = 'Поле "Никнейм" не может быть пустым.';
      isValid = false;
    } else if (!/^[a-zA-Z0-9]{3,}$/.test(username.value)) {
      errors.value.username = 'Никнейм должен содержать минимум 3 символа, только буквы и цифры.';
      isValid = false;
    }

    // Email: формат "aaaa@bb.cc"
    if (!email.value) {
      errors.value.email = 'Поле "Email" не может быть пустым.';
      isValid = false;
    } else if (!/^[a-zA-Z0-9._%+-]{1,}@[a-zA-Z]{1,}\.[a-zA-Z]{2,}$/.test(email.value)) {
      errors.value.email = 'Email должен быть в формате "a@b.cc"';
      isValid = false;
    }

    // Пароль: минимум 8 символов, буквы, цифры, спецсимволы (!@#$%^&* и др.)
    if (!password.value) {
      errors.value.password = 'Поле "Пароль" не может быть пустым.';
      isValid = false;
    } else if (!/^[a-zA-Z0-9!@#$%^&*]{8,}$/.test(password.value)) {
      errors.value.password = 'Пароль должен быть не менее 8 символов и может содержать буквы, цифры и спецсимволы (!@#$%^&*).';
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
        router.push('/main');
      } catch (error) {
        console.error('Ошибка регистрации:', error);
      }
    }
  };
</script>

<template>
  <div class="registration-container">
    <Card>
      <template #title>
        <div class="centered-title">Регистрация</div>
      </template>
      <template #content>
        <div class="inputs">
          <div class="p-field">
            <label for="name">Ваше имя</label>
            <div class="input-wrapper">
              <InputText id="name" v-model="name" @input="clearError('name')" />
            </div>
            <small v-if="errors.name" class="p-error">{{ errors.name }}</small>
          </div>
          <div class="p-field">
            <label for="lastName">Ваша фамилия</label>
            <div class="input-wrapper">
              <InputText id="lastName" v-model="lastName" @input="clearError('lastName')" />
            </div>
            <small v-if="errors.lastName" class="p-error">{{ errors.lastName }}</small>
          </div>
          <div class="p-field">
            <label for="username">Ваш никнейм</label>
            <div class="input-wrapper">
              <InputText id="username" v-model="username" @input="clearError('username')" />
            </div>
            <small v-if="errors.username" class="p-error">{{ errors.username }}</small>
          </div>
          <div class="p-field">
            <label for="email">Email</label>
            <div class="input-wrapper">
              <InputText id="email" v-model="email" @input="clearError('email')" />
            </div>
            <small v-if="errors.email" class="p-error">{{ errors.email }}</small>
          </div>
          <div class="p-field">
            <label for="password">Пароль</label>
            <div class="input-wrapper">
              <Password id="password"
                        v-model="password"
                        feedback="false"
                        :style="{ width: '100%' }"
                        :inputStyle="{ width: '100%' }"
                        @input="clearError('password')" />
            </div>
            <small v-if="errors.password" class="p-error">{{ errors.password }}</small>
          </div>
        </div>
</template>
      <template #footer>
        <Button label="Зарегистрироваться" icon="pi pi-check" @click="signUp" class="footer-button" />
        <div class="footer-text">
          <span>Вы зарегистрированы?</span>
          <a href="/login" class="login-link">Войти</a>
        </div>
      </template>
    </Card>
  </div>
</template>

<style scoped>
  .registration-container {
    display: flex; 
    flex-direction: column;
    justify-content: center;
    align-items: center; 
    min-height: 100vh;
    width: 100%; 
    overflow-y: auto; 
    background-color: #f5f5f5;
    padding: 1rem;
    box-sizing: border-box; 
  }
  .p-card {
    width: 100%;
    max-width: 400px; 
    height: auto;
    box-sizing: border-box;
    overflow: visible; 
  }

  .inputs {
      margin-top: 3rem;
      margin-bottom: -1rem;
  }

  @media (max-width: 768px) {
    .p-card {
      padding: 1rem; 
    }

    .registration-container {
      padding: 0.5rem;
    }
  }

  .p-field {
    margin-top: 1rem;
    margin-bottom: 3rem;
    position: relative; 
    display: flex;
    flex-direction: column;
    align-items: center;
  }
    .p-field label {
      position: absolute;
      top: -2rem;
      left: 50%; 
      transform: translateX(-50%); 
      width: 75%; 
      text-align: left;
      font-weight: bold;
      margin-bottom: 0.25rem;
    }

    .p-field small {
      display: block; 
      margin-top: 0.25rem; 
    }

  .input-wrapper {
    width: 75%;
  }

    .input-wrapper input {
      width: 100%; 
    }

  .p-error {
    margin-top: 0.25rem; 
    color: red;
    font-size: 0.75rem;
    text-align: left;
    width: 95%; 
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

  .footer-button {
    
    margin: 0 auto;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center; 
  }

  .footer-text {
    margin-top: 0.5rem;
    text-align: center;
    font-size: 0.875rem;
    color: #333;
  }

    .footer-text .login-link {
      margin-left: 0.2rem; 
      color: #007bff; 
      text-decoration: none;
    }

      .footer-text .login-link:hover {
        text-decoration: underline; 
      }
</style>
