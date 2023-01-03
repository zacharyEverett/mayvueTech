<template>
  <div>
    <h1>Movies</h1>
    <table class="table">
      <tr>
        <th>Title</th>
        <th>Release Year</th>
        <th>Description</th>
        <th>Actions</th>
      </tr>
      <tr v-for="item in movies" :key="item.title" class="row">
        <td>{{ item.title }} </td>
        <td> {{ item.releaseYear }} </td>
        <td> {{ item.description }} </td>
        <td>
          <i class="fa-solid fa-pen-to-square" id="edit"></i>
          <i class="fa-regular fa-copy" id="copy"></i>
          <i class="fa-solid fa-trash" id="delete"></i>
        </td>
        
      </tr>
    </table>
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
.table {
  border: 1px solid black;
  border-radius: 5px;
  margin: auto;
  height: auto;
  width: 40%;
  border-collapse: collapse;
  
}

tr {
  border-bottom: 1px solid black;

}

#edit{
  margin-right: 12%;
}
#copy {
  margin-right: 12%;
}
</style>