import { createApp } from 'vue';
import App from './App.vue';
import router from './router';

// Import Bootstrap
import 'bootstrap/dist/css/bootstrap.css';

// Import globálních stylů
import './global.css';

createApp(App)
  .use(router)
  .mount('#app');
