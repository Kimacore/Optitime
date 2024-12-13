import { defineStore } from 'pinia';
import apiClient from './axios.js';

const decodeToken = (token) => {
  try {
    const payload = JSON.parse(atob(token.split('.')[1]));
    return payload;
  } catch (e) {
    console.error('Ошибка при декодировании токена:', e);
    return null;
  }
};

const isTokenExpired = (token) => {
  const decoded = decodeToken(token);
  if (!decoded || !decoded.exp) return true;

  const now = Math.floor(Date.now() / 1000);
  return now > decoded.exp;
};

export const useAuthStore = defineStore('auth', {
  state: () => ({
    token: null,
    isAuthenticated: false,
  }),
  actions: {
    restoreAuth() {
      const token = localStorage.getItem('authToken');
      if (token && !isTokenExpired(token)) {
        this.token = token;
        this.isAuthenticated = true;
        apiClient.defaults.headers.common['Authorization'] = `Bearer ${token}`;
      } else {
        this.logout();
      }
    },
    async login(username, password) {
      try {
        const response = await apiClient.post(`/login/${username}`, password);

        const token = response.data;
        this.token = token;
        this.isAuthenticated = true;

        localStorage.setItem('authToken', token);
        apiClient.defaults.headers.common['Authorization'] = `Bearer ${token}`;

        const payload = decodeToken(token);
        console.log('Payload:', payload);
      } catch (error) {
        console.error('Ошибка авторизации:', error);
        throw error;
      }
    },

    async register({ username, name, lastName, email, password }) {
      try {
        const userdto = {
          Login: username,
          Name: name,
          LastName: lastName,
          Email: email,
          Password: password
        };
        console.log({
          login: username,
          name: name,
          lastName: lastName,
          email: email,
          password: password
        });
        const response = await apiClient.post('/register', userdto);
        console.log('Регистрация успешна:', response.data);
        const token = response.data;
        this.token = token;
        this.isAuthenticated = true;
        localStorage.setItem('authToken', token);
        apiClient.defaults.headers.common['Authorization'] = `Bearer ${token}`;
      } catch (error) {
        console.error('Ошибка регистрации:', error);
        throw error;
      }
    },

    logout() {
      this.token = null;
      this.isAuthenticated = false;
      localStorage.removeItem('authToken');
      delete apiClient.defaults.headers.common['Authorization'];
    },
    
  },
});
