### 블로그 Post API
</br>

> - Base api: https://localhost:7113/api/v1
> 

</br>

|Feature|Method|End Point|Request Body|Response Body|Status Code|
|---|---|---|---|---|---|
|전체 글 조회|`GET`|/posts|-|[{<br/>"id": int,<br/>"title": string,<br/>"category": string,<br/>"content": string,<br/>"createdAt": dateTime,</br>"updatedAt": dateTime</br>}]|200 Success|
|단일 글 조회|`GET`|/posts/{postId}|-|{<br/>"id": int,<br/>"title": string,<br/>"category": string,<br/>"content": string,<br/>"createdAt": dateTime,</br>"updatedAt": dateTime</br>}|200 Success|
|글 생성|`POST`|/posts|{<br/>"title": string,<br/>"category": string,<br/>"content": string<br/>}|단일 글 조회와 동일|200 Success|
|글 수정|`PUT`|/posts/{postId}|{<br/>"title": string,<br/>"category": string,<br/>"content": string<br/>}|단일 글 조회와 동일|200 Success|
|글 삭제|`DELETE`|/posts/{postId}|-|-|204 NoContent|

<br/>

## Note!
- 아직 DB 저장 하지 않음
- 모든 변수가 필수값이 아닌 상태
- Error Message 생성하지 않음