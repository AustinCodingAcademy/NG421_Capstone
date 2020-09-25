import { Component, OnInit } from '@angular/core';
import { DbzService } from '../services/dbz.service';
import { DbzMembers } from '../interfaces/dbz-member';

@Component({
  selector: 'app-dbz',
  templateUrl: './dbz.component.html',
  styleUrls: ['./dbz.component.css']
})
export class DbzComponent implements OnInit {

  public dbzMembers: DbzMembers[];
  public newMember: DbzMembers = {
    id: undefined,
    name: '',
    attack: '',
  };
  constructor(private dbzService: DbzService) { }

  async ngOnInit() {
    this.dbzMembers = await this.dbzService.getMembers();
  }

}
