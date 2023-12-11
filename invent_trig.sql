
CREATE OR REPLACE TRIGGER tr_inventory_audit_ins
AFTER INSERT ON inventory
FOR EACH ROW
BEGIN
    INSERT INTO audit_inventory (equipid, operation, sysdate)
    VALUES (NEW.equipid, 'insert', CURDATE());
END//

CREATE OR REPLACE TRIGGER tr_inventory_audit_upd
AFTER UPDATE ON inventory
FOR EACH ROW
BEGIN
    INSERT INTO audit_inventory (equipid, operation, sysdate)
    VALUES (OLD.equipid, 'update', CURDATE());
END//

CREATE OR REPLACE TRIGGER tr_inventory_audit_del
AFTER DELETE ON inventory
FOR EACH ROW
BEGIN
    INSERT INTO audit_inventory (equipid, operation, sysdate)
    VALUES (OLD.equipid, 'delete', CURDATE());
END//

DELIMITER ;
