<script>
  import { ref } from 'vue';
  import Card from 'primevue/card';
  import InputText from 'primevue/inputtext';
  import Password from 'primevue/password';
  import Button from 'primevue/button';
  import { useRouter } from 'vue-router';
  import { useAuthStore } from '../auth.js';

  export default {
    name: 'LoginView',
    components: {
      Card,
      InputText,
      Password,
      Button
    },
    setup() {
      const username = ref('');
      const password = ref('');
      const router = useRouter();
      const authStore = useAuthStore();

      const signIn = async () => {
        await authStore.login(username.value, password.value);
        router.push('/')
      }

      return { username, password, signIn };
    
    }
  };
</script>

<template>
  <Card>
    <template #title>
      <div class="centered-title">Авторизация</div>
    </template>
    <template #content>
      <div class="p-field">
        <label for="username">Имя пользователя</label>
        <InputText id="username" v-model="username" />
      </div>
      <div class="p-field">
        <label for="password">Пароль</label>
        <Password id="password" v-model="password" />
      </div>
    </template>
    <template #footer>
      <Button label="Войти" icon="pi pi-check" @click="signIn" />
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
</style>
