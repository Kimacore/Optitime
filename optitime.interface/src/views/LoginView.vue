<script setup>
  import { ref } from 'vue';
  import Card from 'primevue/card';
  import InputText from 'primevue/inputtext';
  import Password from 'primevue/password';
  import Button from 'primevue/button';
  import { useRouter } from 'vue-router';
  import { useAuthStore } from '../auth.js';

  const username = ref('');
  const password = ref('');
  const router = useRouter();
  const authStore = useAuthStore();
  const errors = ref({
    username: '',
    password: ''
  });

  const validateForm = () => {
    errors.value = {
      username: '',
      password: ''
    };

    let isValid = true;

    if (!username.value) {
      errors.value.username = 'Поле "Имя пользователя" не может быть пустым.';
      isValid = false;
    }

    if (!password.value) {
      errors.value.password = 'Поле "Пароль" не может быть пустым.';
      isValid = false;
    }

    return isValid;
  };

  const signIn = async () => {
    if (validateForm()) {
      try {
        await authStore.login(username.value, password.value);
        router.push('/main');
      } catch (error) {
        console.error('Ошибка авторизации:', error);
      }
    }
  };
</script>

<template>
  <div class="login-container">
    <Card>
      <template #title>
        <div class="centered-title">Вход</div>
      </template>
      <template #content>
        <div class="p-field">
          <label for="username">Имя пользователя</label>
          <div class="input-wrapper">
            <InputText id="username" v-model="username" />
          </div>
          <small v-if="errors.username" class="p-error">{{ errors.username }}</small>
        </div>
        <div class="p-field">
          <label for="password">Пароль</label>
          <div class="input-wrapper">
            <Password v-model="password"
                      :feedback="false"
                      :style="{ width: '100%' }"
                      :inputStyle="{ width: '100%' }" />
          </div>
          <small v-if="errors.password" class="p-error">{{ errors.password }}</small>
        </div>
      </template>
      <template #footer>
        <div class="footer-container">
          <Button label="Войти" icon="pi pi-check" @click="signIn" class="centered-button" />
        </div>
        <div class="footer-text">
          <span>Нет аккаунта?</span>
          <a href="/register" class="register-link">Зарегистрироваться</a>
        </div>
      </template>
    </Card>
  </div>
</template>

<style scoped>
  .login-container {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    padding: 1rem;
    background-color: #f5f5f5;
    box-sizing: border-box;
  }

  .p-card {
    width: 300px;
    max-width: 100%;
    height: auto;
    box-sizing: border-box;
    overflow: visible;
  }

  .p-field {
    margin-top: 1rem;
    margin-bottom: 3rem;
    position: relative;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

    .p-field small {
      display: block;
      margin-top: 0.25rem;
    }

    .p-field label {
      position: absolute;
      top: -2rem;
      left: 50%;
      transform: translateX(-50%);
      width: 95%;
      text-align: left;
      font-weight: bold;
      margin-bottom: 0.25rem;
    }

  .input-wrapper {
    width: 95%;
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

  .footer-container {
    display: flex;
    justify-content: center;
  }

  .centered-button {
    margin: 0 auto;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
  }

  .centered-title {
    text-align: center;
    font-size: 1.5em;
    font-weight: bold;
    margin-bottom: 1rem;
  }

  .footer-text {
    margin-top: 1rem;
    text-align: center;
    font-size: 0.875rem;
    color: #333;
  }

    .footer-text .register-link {
      margin-left: 0.2rem;
      color: #007bff;
      text-decoration: none;
    }

      .footer-text .register-link:hover {
        text-decoration: underline;
      }
</style>
