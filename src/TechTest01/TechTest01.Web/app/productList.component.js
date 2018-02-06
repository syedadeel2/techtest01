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
var http_1 = require("@angular/common/http");
var ProductListComponent = /** @class */ (function () {
    function ProductListComponent(http) {
        var _this = this;
        this.products = function () { return _this.productList; };
        this.httpObj = http;
    }
    ProductListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.httpObj.get("/products/all").subscribe(function (data) {
            var index;
            for (index in data) {
                _this.productList.push(data[index]);
            }
        });
    };
    ProductListComponent = __decorate([
        core_1.Component({
            selector: 'product-list',
            template: "\n<div ngFor=\"let product of products\" class=\"col-xs-6 col-md-4\">\n    <div class=\"product tumbnail thumbnail-3\">\n        <a href=\"{{product.Slug}}\"><img src=\"{{product.ImageUrl}}\" alt=\"\"></a>\n        <div class=\"caption\">\n            <h6><a href=\"{{product.Slug}}\">{{product.Name}}</a></h6><span class=\"price\">\n            </span><span class=\"price sale\">$ {{product.Price}}</span>\n        </div>\n    </div>\n</div>\n",
        }),
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], ProductListComponent);
    return ProductListComponent;
}());
exports.ProductListComponent = ProductListComponent;
//# sourceMappingURL=productList.component.js.map