namespace DemoWebAPI.Controllers {

    export class HomeController {
        public message;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/products').then((response) => { 
                this.message = response.data;
            })
        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
