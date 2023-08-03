use taskboard;
select * from aspnetusers;
select * from tasks;

INSERT INTO tasks (Title, `Description`, BoardId, CreatedOn, OwnerId)
VALUES ('TEST TASK 2', 'TEST TASK Description', '2', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d'),
('TEST TASK 3', 'TEST TASK Description', '3', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d'),
('TEST TASK 4', 'TEST TASK Description', '1', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d');

insert into boards (`name`) values ('On hold');

select * from boards;

INSERT INTO tasks (Title, `Description`, BoardId, CreatedOn, OwnerId)
VALUES ('TASK ON NEW BOARD 1', 'TASK Description', '4', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d'),
('TASK ON NEW BOARD 2', 'TASK Description', '4', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d'),
('TASK ON NEW BOARD 3', 'TASK Description', '4', NOW(), 'deb5a056-18e1-4a46-9bfc-2717ac01d37d');

select * from tasks;

DELETE FROM tasks WHERE Title = 'TASK ON NEW BOARD 2';

select id FROM tasks WHERE Title = 'TASK ON NEW BOARD 2';

DELETE FROM tasks WHERE id = 16;

select * from tasks;

DELETE FROM tasks WHERE Title = 'TASK ON NEW BOARD 3' AND BoardId = 4;

select id from taskboard.tasks WHERE Title = 'New Task from UI for Homework';

select * from taskboard.tasks WHERE Title = 'New Task from UI for Homework';

select * from taskboard.tasks;

UPDATE taskboard.tasks
SET Title = "Updated name of the Task from Workbench",
Description = "Updated description of the Task from Workbench regarding homework on 03.08"
WHERE id = 18;

select * from taskboard.aspnetusers;

select id from taskboard.aspnetusers
where UserName = "abcd";

select * from taskboard.tasks
where ownerid = "deb5a056-18e1-4a46-9bfc-2717ac01d37d";