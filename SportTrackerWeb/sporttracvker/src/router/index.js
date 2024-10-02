import { createRouter, createWebHistory } from 'vue-router';
import HomePage from '@/views/HomePage.vue';
import Activities from '@/views/Activities.vue';
import CreateActivity from '@/views/CreateActivity.vue';

const routes = [
  {
    path: '/',
    name: 'HomePage',
    component: HomePage
  },
  {
    path: '/activities',
    name: 'Activities',
    component: Activities
  },
  {
    path: '/create-activity',
    name: 'CreateActivity',
    component: CreateActivity
  }
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
