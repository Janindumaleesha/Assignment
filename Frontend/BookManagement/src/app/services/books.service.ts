import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { enviroment } from '../../environments/enviroment';
import { Book } from '../models/books.model';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  baseApiUrl : string = enviroment.baseApiUrl;

  constructor() { }

  http = inject(HttpClient)

  getAllBooks()  { 
    return this.http.get<Book[]>(this.baseApiUrl + 'api/book');
  }
}
