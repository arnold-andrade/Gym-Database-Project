DELIMITER //
CREATE FUNCTION check_students_count(tid INT) RETURNS BOOLEAN
BEGIN
    DECLARE no_of_students INT;
    
    SELECT COUNT(*) INTO no_of_students
    FROM trains
    WHERE trainerid = tid;

    IF no_of_students > 10 THEN
        RETURN FALSE;
    ELSE
        RETURN TRUE;
    END IF;
END;
//
DELIMITER ;