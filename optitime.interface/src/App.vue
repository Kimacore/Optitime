<script setup>
  import { RouterView } from 'vue-router';
  import { useAuthStore } from './auth.js';

  const authStore = useAuthStore();

  authStore.restoreAuth();

</script>

<template>
  <RouterView />
</template>


