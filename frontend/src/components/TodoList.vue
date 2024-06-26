<template>
<div>
<hr> <hr> 
</div>
  <div>
    <!-- Textbox for adding new todo (sticky at top) -->
    <div class="add-todo-container">
      <form @submit.prevent="addTodo">
        <label>New Todo:</label>
        <input v-model="newTodoTitle" type="text" />
        <button type="submit">Add Todo</button>
      </form>
    </div>

    <!-- Table to display todos (with colored background) -->
    <div class="todo-table-container">
      <h2>Todo List</h2>
      <table class="todo-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Title</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="todo in todos" :key="todo.id" :class="{ 'row-highlight': todo.id % 2 === 0 }">
            <td>{{ todo.id }}</td>
            <td>{{ todo.title }}</td>
            <td>
              <button @click="deleteTodo(todo.id)">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import TodoService from '../services/TodoService.js';

export default {
  data() {
    return {
      todos: [],
      newTodoTitle: ''
    };
  },
  created() {
    this.fetchTodos();
  },
  methods: {
    async fetchTodos() {
      try {
        const response = await TodoService.getTodos();
        this.todos = response.data;
      } catch (error) {
        console.error('Error fetching todos:', error);
      }
    },
    async addTodo() {
      try {
        const newTodo = { title: this.newTodoTitle };
        await TodoService.createTodo(newTodo);
        this.newTodoTitle = '';
        this.fetchTodos();
      } catch (error) {
        console.error('Error adding todo:', error);
      }
    },
    async deleteTodo(id) {
      try {
        await TodoService.deleteTodo(id);
        this.fetchTodos();
      } catch (error) {
        console.error('Error deleting todo:', error);
      }
    }
  }
};
</script>

<style>
.add-todo-container {
  top: 5em;
  background-color: #ffffff;
  padding: 10px;
  border-bottom: 1px solid #ddd;
  text-align: center;
}

.todo-table-container {
  margin-top: 20px;
  padding: 20px;
}

.todo-table {
  width: 100%;
  border-collapse: collapse;
}

.todo-table th,
.todo-table td {
  border: 1px solid #ddd;
  padding: 8px;
  text-align: left;
}

.todo-table th {
  background-color: #f2f2f2;
}

/* Alternate row background color */
.row-highlight {
  background-color: #f9f9f9;
}
h2
{
  text-align: center;
}
</style>
