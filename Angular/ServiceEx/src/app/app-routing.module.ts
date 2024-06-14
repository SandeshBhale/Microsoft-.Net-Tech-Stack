import { NgModule, createComponent } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { CustomerComponent } from './customer/customer.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';
import { DeleteComponent } from './delete/delete.component';

const routes: Routes = [
  { path: 'prod', component: ProductComponent },
  { path: 'cust', component: CustomerComponent },
  { path: 'details/:cid/:cname', component: DetailsComponent },
  { path: 'create', component: CreateComponent },
  { path: 'edit/:cid', component: EditComponent },
  { path: 'delete/:cid', component: DeleteComponent },
  { path: '', redirectTo: 'wel', pathMatch: 'full' },
  { path: '**', component: WelcomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
