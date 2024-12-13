import axios from 'axios';

const apiClient = axios.create({
  baseURL: 'http://localhost:5255/',
  headers: { 'Content-Type': 'application/json' },
});

apiClient.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response && error.response.status === 401) {
      console.error('Unauthorized');
    }
    return Promise.reject(error);
  }
);

export default apiClient;
