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
var ProductComponent = /** @class */ (function () {
    function ProductComponent(service, route, router) {
        this.service = service;
        this.route = route;
        this.router = router;
    }
    ProductComponent.prototype.ngOnInit = function () {
        var _this = this;
        var slug = this.route.snapshot.paramMap.get('slug');
        this.service.getProduct(slug).subscribe(function (product) {
            _this.product = product;
        });
    };
    ProductComponent = __decorate([
        core_1.Component({
            selector: 'product',
            template: "\n<div class=\"row\">\n<button type=\"button\" (click)=\"this.router.navigate(['/products'])\">Back to Catalog</button>\n    <div class=\"product-detail\">\n        <div class=\"col-xs-4 item-photo\">\n            <img style=\"max-width:100%;\" src=\"{{product.ImageUrl}}\" />\n        </div>\n        <div class=\"col-xs-5\" style=\"border:0px solid gray\">\n            <h3>{{product.Name}}</h3>\n\n            <h6 class=\"title-price\"><small>Price</small></h6>\n            <h3 style=\"margin-top:0px;\">US$ {{product.Price}}</h3>\n\n\n\n            <div class=\"section\" style=\"padding-bottom:20px;\">\n                <h6 class=\"title-attr\"><small>Qty</small></h6>\n                <div>\n                    <div class=\"btn-minus\"><span class=\"glyphicon glyphicon-minus\"></span></div>\n                    <input value=\"1\" />\n                    <div class=\"btn-plus\"><span class=\"glyphicon glyphicon-plus\"></span></div>\n                </div>\n            </div>\n\n\n            <div class=\"section\" style=\"padding-bottom:20px;\">\n                <button class=\"btn btn-success\" type=\"button\" onclick=\"alert( 'This is a button without any functionality' );\"><span style=\"margin-right:20px\" class=\"glyphicon glyphicon-shopping-cart\" aria-hidden=\"true\"></span>Add To Cart</button>\n            </div>\n        </div>\n\n        <div class=\"col-xs-9\">\n            <ul class=\"menu-items\">\n                <li class=\"active\">Description</li>\n            </ul>\n            <div style=\"width:100%;border-top:1px solid silver\">\n                <p style=\"padding:15px;\">\n                    <small>\n                        {{product.Description}}\n                    </small>\n                </p>\n            </div>\n        </div>\n    </div>\n</div>\n",
            providers: [products_service_1.ProductService]
        }),
        __metadata("design:paramtypes", [products_service_1.ProductService, router_1.ActivatedRoute, router_1.Router])
    ], ProductComponent);
    return ProductComponent;
}());
exports.ProductComponent = ProductComponent;
//# sourceMappingURL=product.component.js.map