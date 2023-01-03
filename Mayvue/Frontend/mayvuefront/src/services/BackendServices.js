import axios from "axios"

export default {
    getAllMovies() {
        return axios.get("/Movie")
    }


}