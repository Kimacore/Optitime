import { createRouter, createWebHistory } from 'vue-router';
import { useAuthStore } from './auth.js';

import MainPageView from './views/MainPageView.vue';
import MainPage from './components/MainPage.vue';
import LoginView from './views/LoginView.vue';
import RegistrationView from './views/RegistrationView.vue';
import UserProfile from './components/UserProfile.vue';
import Reports from './components/Reports.vue';
import Projects from './components/Projects.vue';
import MyOrganization from './components/MyOrganization.vue';
import WelcomeView from './views/WelcomeView.vue';
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: MainPageView,
      meta: { auth: true },
      children: [
        { path: 'main', component: MainPage, meta: { auth: true } },
        { path: 'profile', component: UserProfile, meta: { auth: true } },
        { path: 'reports', component: Reports, meta: { auth: true } },
        { path: 'projects', component: Projects, meta: { auth: true } },
        { path: 'organization', component: MyOrganization, meta: { auth: true } },
      ],
    },
    { path: '/login', component: LoginView, meta: { auth: false } },
    { path: '/register', component: RegistrationView, meta: { auth: false } },
    { path: '/welcome', component: WelcomeView, meta: { auth: false } }
  ],
});

router.beforeEach(async (to, from, next) => {
  const authStore = useAuthStore(); 
  await authStore.restoreAuth();
  const requiresAuth = to.meta.auth;
  if (requiresAuth && !authStore.isAuthenticated) {
    next('/welcome');
  } else if (!requiresAuth && authStore.isAuthenticated && (to.path === '/login' || to.path === '/register' || to.path === '/')) {
    next('/main');
  } else {
    next();
  }
});

export default router;
