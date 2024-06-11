import { Component } from "@angular/core";

@Component({
    selector: 'dir',
    templateUrl: 'directive.component.html'
})

export class DirectiveComponent {
    flag: boolean = false;
    val: number = 0;
    toggle(): void {
        this.flag = !this.flag;
    }
}