import './assets/main.css';
import PrimeVue from 'primevue/config';
import "primeicons/primeicons.css";
import 'primeflex/primeflex.css';
import 'primevue/resources/themes/aura-light-lime/theme.css';
import { createApp } from 'vue';
import { createPinia } from 'pinia';
import App from './App.vue';
import router from './router.js';
import apiClient from './axios.js'
import { useAuthStore } from './auth.js';
const app = createApp(App);
app.use(createPinia());
app.use(router);
app.use(PrimeVue);
const authStore = useAuthStore();
authStore.restoreAuth();
app.mount('#app');
