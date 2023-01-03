<template>
  <div>
    <h1>Test</h1>
    <div v-for="item in movies" :key="item.title">
      <h1>{{ item.title }}</h1>
    </div>
  </div>
</template>

<script>
import BackendServices from '../services/BackendServices';
export default {
data() {
  return {
    movies: []
  }
},
created() {
  this.getMovies();
},
methods: {
  getMovies(){
    BackendServices.getAllMovies().then((returned) => {
      returned.data.forEach(element => {
        this.movies.push(element);
      });
    })
    
  }
},
}
</script>

<style>

</style>