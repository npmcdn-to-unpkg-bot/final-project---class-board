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
var core_1 = require('@angular/core');
var nav_element_service_1 = require('./nav-element.service');
var canvas_directive_1 = require('./canvas.directive');
var CanvasComponent = (function () {
    function CanvasComponent() {
    }
    CanvasComponent = __decorate([
        core_1.Component({
            selector: 'bc-canvas',
            templateUrl: 'app/canvas.component.html',
            styleUrls: ['app/canvas.component.css'],
            providers: [nav_element_service_1.NavElementService],
            directives: [canvas_directive_1.CanvasDirective]
        }), 
        __metadata('design:paramtypes', [])
    ], CanvasComponent);
    return CanvasComponent;
}());
exports.CanvasComponent = CanvasComponent;
//# sourceMappingURL=canvas.component.js.map