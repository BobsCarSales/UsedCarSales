--model has a single make
--vehicle has many models

INSERT INTO Make (id, name) VALUES (1, "Toyota");
INSERT INTO Make (id, name) VALUES (2, "Audi");
INSERT INTO Make (id, name) VALUES (3, "BMW");

INSERT INTO Model (id, name, make) VALUES (1, "Camry", 1);
INSERT INTO Model (id, name, make) VALUES (2, "A1", 2);
INSERT INTO Model (id, name, make) VALUES (3, "X1", 3);
INSERT INTO Model (id, name, make) VALUES (4, "Yaris", 1);

INSERT INTO Vehicle (id, used, sold, model) VALUES (1, false, false, 1);
INSERT INTO Vehicle (id, used, sold, model) VALUES (2, true, false, 2);
INSERT INTO Vehicle (id, used, sold, model) VALUES (3, false, true, 3);
INSERT INTO Vehicle (id, used, sold, model) VALUES (4, true, true, 4);
