import { Component, OnInit } from '@angular/core';
import { Log } from '../../models/log';
import { LogService } from '../../services/log.service';

@Component({
  selector: 'app-logs',
  templateUrl: './logs.component.html',
  styleUrls: ['./logs.component.css']
})
export class LogsComponent implements OnInit {

  logs:Log[]; // set array
  selectedLog: Log;
  loaded : boolean = false;
  constructor(private logService:LogService) { }

  ngOnInit() {
    // this.logService.stateClear.subscribe(clear =>{
    //   this.selectedLog = {
    //     id:'',
    //     text: '',
    //     date:''
    //   }
    // });

    this.logService.getLogs().subscribe(logs => {
      console.log(logs);
      this.logs = logs;
      console.log(this.logs);
      this.loaded = true;
      if(this.logs !== null)
        console.log('this is filled');
      
    });
  }

  onSelect(log: Log){
    // console.log(log);
    this.logService.setFormLog(log);
    this.selectedLog = log;
  }

  onDelete(log:Log){
    if(confirm('Are you sure?')){
      this.logService.deleteLog(log);
    }
  }
}
