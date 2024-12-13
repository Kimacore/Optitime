<script>
  import { ref } from 'vue';
  import Button from 'primevue/button';
  import { useAuthStore } from '../auth.js';
  import { useRouter } from 'vue-router';
  export default {
    name: 'MainPageView',
    setup() {
      const authStore = useAuthStore();
      const router = useRouter();
      const logout = () => {
        authStore.logout();
        router.push('/login');
      };

      return { logout, authStore };
    },
  };
    
</script>

<template>
  <div>
    <h1>Главная Страница</h1>
    <nav>
      <ul>
        <li><router-link to="/profile">Профиль</router-link></li>
        <li><router-link to="/reports">Отчёты</router-link></li>
        <li><router-link to="/projects">Проекты</router-link></li>
        <li><router-link to="/organization">Организация</router-link></li>
        <Button label="Logout" icon="pi pi-check" @click="logout" />
      </ul>
    </nav>

    <router-view />
  </div>
</template>

<style scoped>
  nav ul {
    list-style: none;
    padding: 0;
  }

    nav ul li {
      display: inline-block;
      margin: 0 10px;
    }

      nav ul li a {
        text-decoration: none;
        color: #333;
        font-weight: bold;
      }

        nav ul li a.router-link-active {
          color: blue;
        }

  .card {
    background: #fff;
    padding: 20px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    margin-top: 20px;
  }
</style>
