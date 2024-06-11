import { Component } from "@angular/core";

@Component({
    selector:'dir',
    templateUrl:'directive.component.html'
})

export class DirectiveComponent{
    flag:boolean=false;

    toggle():void{
        this.flag=!this.flag;
    }
}