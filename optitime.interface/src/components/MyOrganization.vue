<script setup>
  const user = {
    name: 'Влад',
    lastname: 'Кобяков',
    email: 'ivan@example.com',
    age: 25,
  };
</script>

<template>
  <div class="container">

    <div class="main-content">
      <div class="section-header">
        <h1>Организации</h1>
      </div>
      <div class="profile-content">
        
      </div>
    </div>
  </div>
</template>

<style scoped>
  .container {
    display: flex;
    min-height: 100vh;
  }

  .sidebar {
    width: 250px;
    background-color: #f4f4f4; 
    padding: 20px;
    box-shadow: 2px 0 5px rgba(0, 0, 0, 0.1);
  }

    .sidebar ul {
      list-style: none;
      padding: 0;
    }

      .sidebar ul li {
        margin: 15px 0;
      }

    .sidebar a {
      text-decoration: none;
      color: #333;
      font-weight: bold;
    }

  .main-content {
    flex-grow: 1; 
    padding: 20px;
    background-color: #fff; 
    display: flex;
    flex-direction: column;
    width: 100%;
  }

  .section-header {
    background-color: #4CAF50;
    color: white;
    padding: 15px 20px;
    border-radius: 5px; 
    margin-bottom: 20px;
    width: 100%;
  }

 

  .profile-content {
    margin-top: 20px;
  }

  @media (max-width: 768px) {
    .sidebar {
      width: 200px;
    }

    .main-content {
      padding: 10px; 
    }

    .section-header {
      padding: 10px; 
    }
  }
</style>
