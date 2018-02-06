import { Component } from '@angular/core';
import { ProductListComponent } from './productList.component';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'my-app',
  template: `
<h1>Welcome To {{name}}</h1> 

<div class="row">
<router-outlet></router-outlet>
</div>
`,
})
export class AppComponent {
    name = 'True Alliance SPA Site';

    constructor( private route: ActivatedRoute, private router: Router ) {
        this.router.navigate( ['/products'] );
    }
}
