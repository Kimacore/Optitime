<script setup>
  import { useAuthStore } from '../auth.js';
  import { useRouter } from 'vue-router';
  import { ref, onMounted } from 'vue';
  import Button from 'primevue/button';
  import Sidebar from 'primevue/sidebar';

  const authStore = useAuthStore();
  const router = useRouter();

  // Чтение состояния из localStorage при монтировании компонента
  const isSidebarVisible = ref(localStorage.getItem('sidebarVisible') === 'true'); // Изначальное состояние из localStorage

  const toggleSidebar = () => {
    isSidebarVisible.value = !isSidebarVisible.value;
    // Сохраняем новое состояние в localStorage
    localStorage.setItem('sidebarVisible', isSidebarVisible.value);
  };

  const logout = () => {
    authStore.logout();
    router.push('/login');
  };

  // Можно добавить onMounted, чтобы гарантировать, что состояние сохраняется при первом рендере
  onMounted(() => {
    // В дальнейшем будет использоваться состояние из localStorage
    const savedState = localStorage.getItem('sidebarVisible');
    if (savedState !== null) {
      isSidebarVisible.value = savedState === 'true';
    }
  });
</script>

<template>
  <div class="main-container">
    <!-- Полоска с кнопкой -->
    <div class="sidebar-toggle-strip">
      <Button icon="pi pi-bars"
              class="hamburger-button"
              @click="toggleSidebar"
              aria-label="Toggle Sidebar" />
    </div>

    <!-- Sidebar -->
    <aside class="sidebar" :class="{ visible: isSidebarVisible }">
      <h3>Меню</h3>
      <ul class="sidebar-menu">
        <li :class="{ active: $route.path === '/main' }"><router-link to="/main" class="sidebar-link">Главная страница</router-link></li>
        <li :class="{ active: $route.path === '/profile' }"><router-link to="/profile" class="sidebar-link">Профиль</router-link></li>
        <li :class="{ active: $route.path === '/reports' }"><router-link to="/reports" class="sidebar-link">Отчёты</router-link></li>
        <li :class="{ active: $route.path === '/projects' }"><router-link to="/projects" class="sidebar-link">Проекты</router-link></li>
        <li :class="{ active: $route.path === '/organization' }"><router-link to="/organization" class="sidebar-link">Организация</router-link></li>
      </ul>
      <Button label="Выйти с аккаунта"
              icon="pi pi-sign-out"
              class="logout-button"
              @click="logout"
              aria-label="Logout" />
    </aside>

    <!-- Основной контент -->
    <div class="content" :class="{ 'with-sidebar': isSidebarVisible }">
      <router-view />
    </div>
  </div>
</template>

<style scoped>
  /* Основной контейнер */
  .main-container {
    display: flex;
    min-height: 100vh;
  }

  /* Полоска с кнопкой */
  .sidebar-toggle-strip {
    width: 50px;
    height: 100%;
    background-color: #f0f0f0;
    display: flex;
    align-items: center;
    justify-content: center;
    box-shadow: 2px 0 5px rgba(0, 0, 0, 0.1);
    position: fixed;
    z-index: 1000;
  }

  /* Кнопка гамбургер */
  .hamburger-button {
    width: 40px;
    height: 40px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #fff;
    border: 2px solid #ccc;
    border-radius: 50%;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
    cursor: pointer;
  }

  /* Sidebar */
  .sidebar {
    width: 0;
    height: 100%;
    position: fixed;
    left: 50px; /* Оставляем место для полоски */
    top: 0;
    background-color: #f8f9fa;
    padding: 0px;
    overflow: hidden;
    box-shadow: 2px 0 5px rgba(0, 0, 0, 0.1);
    transition: width 0.3s ease;
    z-index: 1000;
  }

    .sidebar.visible {
      width: 200px; /* Развёрнутая ширина Sidebar */
    }

    .sidebar h3 {
      margin-top: 15px;
      margin-bottom: 15px;
      margin-left: 15px;
    }

  .sidebar-menu {
    list-style: none;
    padding: 0;
    margin: 0;
  }

    .sidebar-menu li {
      
      margin-bottom: 0px;
      text-align:left;
      
    }

  .sidebar-link {
    text-decoration: none;
    color: #333;
    font-weight: bold;
    padding: 10px 15px;
    white-space: nowrap; /* Отключить перенос текста */
    overflow: hidden; /* Скрыть текст, который выходит за границы */
    text-overflow: ellipsis; /* Добавить многоточие, если текст слишком длинный */
    display: block; /* Убедиться, что ссылка занимает всю строку */
  }

    .sidebar-link.router-link-active {
      color: seagreen;
    }

  .sidebar-menu li.active {
    background-color: #e0e0e0; /* Цвет фона при активации */
  }

    .sidebar-menu li.active .sidebar-link {
      color: seagreen; /* Цвет текста в активном состоянии */
    } 
  /* Кнопка Logout */
  .logout-button {
    position: absolute;
    bottom: 20px; /* Располагаем кнопку внизу */
    left: 15px;
    right: 15px;
    height: 40px; /* Увеличен размер для удобства */
    width: calc(100% - 30px); /* Ширина на 30px меньше для отступов */
    background-color: #f44336; /* Красный фон для кнопки */
    color: white; /* Белый цвет текста */
    font-weight: bold;
    border: none;
    border-radius: 4px; /* Слегка округлые углы */
    padding: 10px; /* Отступы внутри кнопки */
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* Тень для кнопки */
    transition: background-color 0.3s ease, transform 0.3s ease; /* Плавный переход для фона и эффекта нажатия */
    text-align: center;
    z-index: 1001; /* Обеспечивает, что кнопка будет поверх других элементов */
    font-size: 0.8rem;
    white-space: nowrap
  }

    .logout-button:hover {
      background-color: #d32f2f; /* Темный красный цвет при наведении */
      transform: scale(1.05); /* Легкое увеличение кнопки при наведении */
    }

    .logout-button .pi {
      margin-right: 8px; /* Отступ между иконкой и текстом */
      font-size: 1.2rem; /* Увеличение иконки */
    }

    .logout-button span {
      font-size: 0.4rem; /* Размер шрифта */
      font-weight: 600; /* Толщина шрифта */
    }

  
  /* Основной контент */
  .content {
    flex: 1;
    margin-left: 50px; /* Оставляем место для полоски */
    padding: 20px;
    transition: margin-left 0.3s ease;
  }

    .content.with-sidebar {
      margin-left: 250px; /* 250px ширина Sidebar + 50px полоска */
    }
</style>
