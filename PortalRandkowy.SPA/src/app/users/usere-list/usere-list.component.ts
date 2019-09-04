import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_models/user';
import { UserService } from 'src/app/_services/user.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { Pagination, PaginationResult } from 'src/app/_models/pagination';

@Component({
  selector: 'app-usere-list',
  templateUrl: './usere-list.component.html',
  styleUrls: ['./usere-list.component.css']
})
export class UsereListComponent implements OnInit {

  users: User[];
  user: User =  JSON.parse(localStorage.getItem('user'));
  genderList = [{value: 'mężczyzna', display: 'Meżczyźni'},
                {value: 'kobieta', display: 'Kobiety'}];
  zodiacSignList = [{value: 'Wszystkie', display: 'Wszystkie'},
      {value: 'Baran', display: 'Baran'},
      {value: 'Byk', display: 'Byk'},
      {value: 'Bliźnięta', display: 'Bliźnięta'},
      {value: 'Rak', display: 'Rak'},
      {value: 'Lew', display: 'Lew'},
      {value: 'Panna', display: 'Panna'},
      {value: 'Waga', display: 'Waga'},
      {value: 'Scorpion', display: 'Skorpion'},
      {value: 'Strzelec', display: 'Strzelec'},
      {value: 'Koziorożec', display: 'Koziorożec'},
      {value: 'Wodnik', display: 'Wodnik'},
      {value: 'Ryby', display: 'Ryby'}];
  userParams: any = {};
  pagination: Pagination;

  constructor(private userService: UserService,
              private alertify: AlertifyService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.users = data.users.result;
      this.pagination = data.users.pagination;
    });
    this.userParams.gender = this.user.gender === 'kobieta' ? 'mężczyzna' : 'kobieta';
    this.userParams.zodiacSign = 'Wszystkie';
    this.userParams.minAge = 18;
    this.userParams.maxAge = 100;
    this.userParams.orderBy = 'lastActive';
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadUsers();
  }

  resetFilters() {
    this.userParams.gender = this.user.gender === 'kobieta' ? 'mężczyzna' : 'kobieta';
    this.userParams.zodiacSign = 'Wszystkie';
    this.userParams.minAge = 18;
    this.userParams.maxAge = 100;
    this.userParams.orderBy = 'lastActive';
    this.loadUsers();
  }

   loadUsers() {
     this.userService.getUsers(this.pagination.currentPage, this.pagination.itemsPerPage, this.userParams)
      .subscribe((res: PaginationResult<User[]>) => {
       this.users = res.result;
       this.pagination = res.pagination;
     }, error => {
       this.alertify.error(error);
     });
   }
}
