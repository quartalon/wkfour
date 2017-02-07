namespace MoviesWebAPI.Controllers {

    export class HomeController {
        public movies;


        constructor(private $http: ng.IHttpService) {
            this.$http.get('api/movies').then((response) => {
                this.movies = response.data;

            })

        }

    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }


}
