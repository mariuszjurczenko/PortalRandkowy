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
  pagination: Pagination;

  constructor(private userService: UserService,
              private alertify: AlertifyService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.users = data.users.result;
      this.pagination = data.users.pagination;
    });
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadUsers();
  }

   loadUsers() {
     this.userService.getUsers(this.pagination.currentPage, this.pagination.itemsPerPage)
      .subscribe((res: PaginationResult<User[]>) => {
       this.users = res.result;
       this.pagination = res.pagination;
     }, error => {
       this.alertify.error(error);
     });
   }
}