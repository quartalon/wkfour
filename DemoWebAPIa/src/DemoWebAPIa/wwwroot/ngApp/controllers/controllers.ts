namespace DemoWebAPIa.Controllers {

    export class HomeController {
        public products;

        constructor(private $http: ng.IHttpService) {
            this.$http.get(`api/products`).then((response) => {
                this.products = response.data;

            })
        }
        }
    //}



    export class AboutController {
        public product;
        constructor(private $stateParams: ng.ui.IStateParamsService, private $http: ng.IHttpService) {
            let productId = this.$stateParams[`id`];

            this.$http.get(`/api/products/` + productId).then((response) => {
                this.product = response.data;
            })
        }
    }

}
