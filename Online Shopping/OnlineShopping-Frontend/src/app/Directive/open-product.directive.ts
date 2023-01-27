import { Directive ,HostListener,Input} from '@angular/core';
import { Router } from '@angular/router';

@Directive({
  selector: '[appOpenProduct]'
})
export class OpenProductDirective {
  @Input() productId:number = 0
  @HostListener('click') openProduct()
  {
    window.scrollTo(0,0);
    this.router.navigate(['/product'],
    {
      queryParams: {
        id: this.productId,
      },
    });
  }
  constructor(private router:Router) { }

}
