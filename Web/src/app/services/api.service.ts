import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private apiUrl: string;

  constructor(private httpClient: HttpClient) {
    this.apiUrl = environment.apiUrl;
  }

  public get<T>(endpoint: string, data: any = null): Observable<any> {
    return this.httpClient.get<T>(this.apiUrl + endpoint, { params: data });
  }

  public post<T>(endpoint: string, data: any): Observable<any> {
    return this.httpClient.post<T>(this.apiUrl + endpoint, data, {});
  }

  public put<T>(endpoint: string, data: any): Observable<any> {
    return this.httpClient.put<T>(this.apiUrl + endpoint, data, {});
  }

  public delete<T>(endpoint: string, data: any): Observable<any> {
    return this.httpClient.delete<T>(this.apiUrl + endpoint, { params: data });
  }

  public async getData<T>(request: Observable<T>): Promise<T> {
    const result = (await lastValueFrom(request));
    if (!result)
      throw Error();

    return new Promise(resolve => {
      resolve(<T>result);
    });
  }
}
