create or replace function checkservice(train_id in int,serv in varchar2)  return integer is
    flag integer;
    begin
     select count(*) into flag
     from trainer
     where trainer.trainerid=train_id and trainer.service=serv;
   return flag;
   end;
   /