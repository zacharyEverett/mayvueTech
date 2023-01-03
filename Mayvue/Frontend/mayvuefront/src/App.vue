<template>
  <movies-item></movies-item>
</template>

<script>
import MoviesItem from './components/MoviesItem.vue';



export default {
  name: "App",
  components: {
    MoviesItem
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
