import { Component } from "@angular/core";

@Component({
    selector:'db',
    templateUrl:'databinding.component.html'
})

export class DataBindingComponent{
    message:string="Hello Public";
    val:number=45;
    flag:boolean=false;

    SayHello():void{
        alert("SayHello Funcation Is Called");
    }

    SayHelloMessage():string{
        return ("SayHello Called");
    }

    toggle():void{
        this.flag = !this.flag;
    }
}