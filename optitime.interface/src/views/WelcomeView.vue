<script setup>
  import Button from 'primevue/button';
  import Card from 'primevue/card';
  import { useRouter } from 'vue-router';
  import { ref, onMounted, onBeforeUnmount } from 'vue';
  import Panel from 'primevue/panel';

  const navbar = ref(null); // Ссылка на элемент navbar
  const isScrolled = ref(false); // Состояние для проверки прокрутки

  const handleScroll = () => {
    if (window.scrollY > 0) {
      isScrolled.value = true;
    } else {
      isScrolled.value = false;
    }
    console.log(isScrolled.value); // Проверим, меняется ли значение
  };

  onMounted(() => {
    window.addEventListener('scroll', handleScroll);
  });

  onBeforeUnmount(() => {
    window.removeEventListener('scroll', handleScroll);
  });
  const router = useRouter();

  const goToLogin = () => {
    router.push('/login');
  };

  const goToRegister = () => {
    router.push('/register');
  };
</script>

<template>
  <div class="main-container">
    <nav :class="['navbar', { 'navbar-scrolled': isScrolled }]">

      <div class="navbar-content">
        <h1 class="logo">Optitime</h1>
        <div class="auth-buttons">
          <Button label="Войти" class="p-button-text" @click="goToLogin" />
          <Button label="Зарегистрироваться" class="p-button-text" @click="goToRegister" />
        </div>
      </div>
    </nav>

    <header class="header">
      <h2>Управляй временем своей команды легко</h2>
      <p>Добро пожаловать в Optitime.</p>
    </header>

    <main>
      <section class="hero">
        <p>
          Успешная работа команды начинается с эффективного планирования. Optitime помогает вам не просто организовать задачи, но и анализировать, как вы тратите время, и использовать его максимально продуктивно.

          Созданное для современного ритма работы, приложение предоставляет удобные инструменты для отслеживания прогресса, распределения задач и достижения целей, сохраняя баланс между работой и личной жизнью.
          <span class="bold-text">Добро пожаловать в мир, где каждая минута под контролем.</span>
        </p>

      </section>

      <section class="features">
        <Card>
          <template #title>
            <h3>Командная работа</h3>
          </template>
          <template #content>
            <p>Создайте команды, объединяя людей для совместной работы над проектами. Распределяйте роли и задачи среди участников, отслеживайте их вклад в выполнение проекта.</p>
          </template>
        </Card>
        <Card>
          <template #title>
            <h3>Отчётность</h3>
          </template>
          <template #content>
            <p>В любой момент вы сможете оценить проделанную работу вами или вашей командой, загрузив отчёт по нужному проекту</p>
          </template>
        </Card>
        <Card>
          <template #title>
            <h3>Проекты</h3>
          </template>
          <template #content>
            <p>Легко создавайте новые проекты с возможностью добавления описания, сроков и важных параметров. Каждый проект будет иметь чёткую структуру для дальнейшего управления задачами и участниками.</p>
          </template>
        </Card>
        <Card>
          <template #title>
            <h3>Простота в управлении правами доступа</h3>
          </template>
          <template #content>
            <p>Каждому пользователю назначаются соответствующие права, будь то администратор, участник или наблюдатель. Легко контролируйте доступ к данным и ресурсам проекта.</p>
          </template>
        </Card>
        <Card>
          <template #title>
            <h3>Контроль времени и ресурсов</h3>
          </template>
          <template #content>
            <p>Отслеживайте рабочее время и ресурсы, используемые в проекте. Это поможет вам эффективно управлять сроками и повышать производительность команды.</p>
          </template>
        </Card>
        <Card>
          <template #title>
            <h3>Интуитивно понятный интерфейс</h3>
          </template>
          <template #content>
            <p>Наш интерфейс прост в использовании и визуально привлекательный. Вы сможете быстро разобраться в программе и начать использовать все её возможности с минимальными усилиями.</p>
          </template>
        </Card>
      </section>
    </main>

    <footer>
      <p>© 2024 Optitime</p>
    </footer>

    
  </div>
</template>

<style scoped>
  .main-container {
    display: flex;
    flex-direction: column;
    min-height: 100vh;
    width: 100%;
    box-sizing: border-box;
    justify-content: center;
    align-items: center;
    background-color: white;
  }

  .navbar {
    position: static;
    top: 0;
    left: 0;
    width: 100%;
    background-color: #f5f5f5;
    border-bottom: 1px solid #ddd;
    z-index: 1000;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    transition: all 1s ease-in;
  }

  .navbar-scrolled {
    position: fixed;
    top: 0;
    background-color: #f5f5f5;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
    transition: all 1s ease-in;
  }

    .navbar-scrolled + .header {
      margin-top: 3.5rem; 
    }

  .navbar-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0.5rem 1rem;
  }

  .logo {
    font-size: 1.5rem;
    font-weight: bold;
  }

  .auth-buttons .p-button {
    margin-left: 0.5rem;
  }

  .header {
    text-align: center;
    padding: 18.2rem 1rem;
    background-color: #8EB897;
    width: 100%;
    margin-top: 0rem;
    box-sizing: border-box;
    
  }

    .header h2 {
      font-size: 3rem;
      color: #d5f5e4;
      margin-bottom: 0rem;
      font-weight: bold;
    }

    .header p {
      font-size: 1.2rem;
      color: #d5f5e4;
    }

  .hero {
    text-align: center;
    margin: 0rem auto;
    width: 100%;
    background-color: seagreen;
    padding: 9rem 1rem;
  }

    .hero p {
      text-align: center;
      margin: 0rem auto;
      width: 75%;
      color: #d5f5e4;
      font-size: 2rem;
    }

  .features {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 1rem;
    padding: 2rem;
    width: 100%;
    justify-items: center;
    justify-content: center;
    margin: 0 auto;
    background-color: seagreen;
  }



  footer {
    text-align: center;
    padding: 1rem;
    background-color: #f5f5f5;
    width: 100%;
  }

  

  .bold-text {
    font-weight: bold;
  }
</style>
