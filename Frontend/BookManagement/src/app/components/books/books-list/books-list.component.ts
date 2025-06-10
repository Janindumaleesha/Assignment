import { Component, inject, OnInit } from '@angular/core';
import { Book } from '../../../models/books.model';
import { CommonModule } from '@angular/common';  
import { BooksService } from '../../../services/books.service';

@Component({

  selector: 'app-books-list',
  imports: [CommonModule],
  templateUrl: './books-list.component.html',
  styleUrl: './books-list.component.css'
})
export class BooksListComponent implements OnInit {

  books: Book[] = [];

  booksServices = inject(BooksService);

  constructor() {}

  ngOnInit(): void {
    this.getBooks();
  }

  getBooks(){
    this.booksServices.getAllBooks().subscribe((res) =>{
      this.books = res;
    })
  }

}
