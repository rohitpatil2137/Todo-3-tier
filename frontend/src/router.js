// src/router.js
import Vue from 'vue';
import Router from 'vue-router';
import TodoList from './components/TodoList.vue';

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: TodoList
    },
    // You can add more routes here for other components/pages
  ]
});
