import axios from 'axios';

const apiClient = axios.create({
  baseURL: 'http://localhost:5004/api',
  withCredentials: false, // This is the default
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json'
  }
});

export default {
  getActivities() {
    return apiClient.get('/activities');
  },
  postActivity(activity) {
    return apiClient.post('/activities', activity);
  },
  // Přidej další metody pro PUT, DELETE podle potřeby
};
