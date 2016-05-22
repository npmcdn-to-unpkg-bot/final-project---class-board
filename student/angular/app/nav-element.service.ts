import { Injectable, Component, EventEmitter, Input, Output } from '@angular/core';

import { NavElement } from './nav-element';
import { NAV_ELEMENTS } from './nav-element-list';

@Injectable()
export class NavElementService {
    private _allNavElements = NAV_ELEMENTS;
    @Input() selectedNavElement:NavElement;
    @Output() changeSelected:EventEmitter<NavElement> = new EventEmitter();



    selectAnother(navElement:NavElement) {
        this.selectedNavElement = navElement;
        console.log("Event Emitted");
        this.changeSelected.emit(navElement);
    }

    getSelectedNavElement() {
        return this.selectedNavElement;
    }

    getNavElements() {
        return NAV_ELEMENTS;
    }

    getMenuNavElements() {
        let menuNavComponent: NavElement[] = [];
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "menu")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "gallery")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "board")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "cursor")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "pen")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "circle")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "text")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "picture")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "eraser")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "undo")[0]);
        menuNavComponent.push(this._allNavElements.filter(element => element.name == "redo")[0]);
        return menuNavComponent;
    }
}