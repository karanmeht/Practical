import {Component} from '@angular/core';

@Component({
selector:'app-root',
template:`
 <h1>{{title}}</h1>
<!--<my-heroes></my-heroes>-->
    <nav>
     <a routerLink="/dashboard">Dashboard</a>
     <a routerLink="/heroes">Heroes</a>
   </nav>
   <router-outlet></router-outlet>
 `
})

export class AppComponent
{
 title = 'Tours of heros';

}