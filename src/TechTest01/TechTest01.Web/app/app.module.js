"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var http_1 = require("@angular/common/http");
var http_2 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var productList_component_1 = require("./productList.component");
var product_component_1 = require("./product.component");
var products_service_1 = require("../app/Services/products.service");
exports.routes = [
    { path: 'products', component: productList_component_1.ProductListComponent },
    { path: 'product/:slug', component: product_component_1.ProductComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, http_1.HttpClientModule, http_2.HttpModule, router_1.RouterModule.forRoot(exports.routes, { useHash: true })],
            declarations: [app_component_1.AppComponent, productList_component_1.ProductListComponent, product_component_1.ProductComponent],
            bootstrap: [app_component_1.AppComponent],
            providers: [products_service_1.ProductService]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map