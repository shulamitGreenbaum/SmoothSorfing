create table tbActionWord(
word_id nvarchar(9),
action_id nvarchar(9)

  primary key(word_id)
)

create table tbKWord(
KeyWordId nvarchar(9),
name nvarchar(10)
  primary key(KeyWordId)
)
create table action(
id int,
name nvarchar(20),
id_volanteer int,
macro int,
count_fidback int

primary key (id)
)

create table volanteer(
id int,
name nvarchar(20),
password nvarchar(20),
emailAddress nvarchar(30)

primary key (id)
)


create table search(
id int,
idAction int,
dit nvarchar

primary key (id)
)

create table fidback(
id_macro int,
idAction int,
like_disLike bit


)
 EXEC sp_rename 'volanteer', 'volunteer','table';
GO    

EXEC sp_rename 'volanteer', 'volunteer'
