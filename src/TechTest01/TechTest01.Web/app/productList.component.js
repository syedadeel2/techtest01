"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var products_service_1 = require("../app/Services/products.service");
var router_1 = require("@angular/router");
var ProductListComponent = /** @class */ (function () {
    function ProductListComponent(service, route, router) {
        this.service = service;
        this.route = route;
        this.router = router;
    }
    ProductListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.service.getProducts().subscribe(function (products) {
            _this.productList = products;
        });
    };
    ProductListComponent.prototype.navigate = function (slug) {
        this.router.navigate(['/product/' + slug]);
    };
    ProductListComponent = __decorate([
        core_1.Component({
            selector: 'product-list',
            template: "\n<h2>Latest Products</h2>\n<div *ngFor=\"let product of productList\" class=\"col-xs-6 col-md-4\">\n    <div class=\"product tumbnail thumbnail-3\">\n        <a (click)=\"navigate(product.Slug)\"><img src=\"{{product.ImageUrl}}\" alt=\"\"></a>\n        <div class=\"caption\">\n            <h6><a (click)=\"navigate(product.Slug)\">{{product.Name}}</a></h6><span class=\"price\">\n            </span><span class=\"price sale\">$ {{product.Price}}</span>\n        </div>\n    </div>\n</div>\n",
            providers: [products_service_1.ProductService]
        }),
        __metadata("design:paramtypes", [products_service_1.ProductService, router_1.ActivatedRoute, router_1.Router])
    ], ProductListComponent);
    return ProductListComponent;
}());
exports.ProductListComponent = ProductListComponent;
//# sourceMappingURL=productList.component.js.map