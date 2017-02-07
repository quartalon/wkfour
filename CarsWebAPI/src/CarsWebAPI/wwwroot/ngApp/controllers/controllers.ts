namespace CarsWebAPI.Controllers {
    //let cars;

    export class HomeController {
        public message = 'Hello from the home page!';
        public slides = [
            { image: "/images/astonmartin.jpg" },
            { image: "/images/roadstr.jpg" },
            { image: "/images/generallee.jpg" },
            { image: "/images/police.jpg" },
            { image: "/images/deucecoupe.jpg" },
        ]
    }

    export class CarsController {
        public cars;

        constructor(private $http: ng.IHttpService) {
            this.$http.get("/api/cars").then((response) => {
                this.cars = response.data;
                //cars = this.cars;
            });

        }
    }

    export class CarDetailsController {
        public car;

        //constructor(private $stateParams: ng.ui.IStateParamsService){
        /*filter is an array iteration function - [0] specifies location in array to return*/
        //this.car = car.filter((c) => { return c.id == $stateParams[`id`] });

        constructor(private $stateParams: ng.ui.IStateParamsService, private $http: ng.IHttpService) {
            this.$http.get("/api/cars/" + this.$stateParams["id"]).then((response) => {
                this.car = response.data;
            });
            console.log(this.car);
        }
    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
