import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class RepositoryService {

  constructor(
    private http: HttpClient
  ) { }

  private repositoriesUrl = ''
}
