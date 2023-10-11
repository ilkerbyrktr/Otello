CREATE TYPE role_type AS ENUM ('manager','user','worker');
CREATE TABLE users(
    id SERIAL PRIMARY KEY ,
    name VARCHAR(20),
    surname VARCHAR(25),
    username VARCHAR(50),
    password VARCHAR(100),
    role role_type
);
CREATE TABLE MesaiSaati (
    id SERIAL PRIMARY KEY,
    user_id INTEGER REFERENCES "users" (id),
    gun VARCHAR(10) NOT NULL,
    mesai_baslangic TIME,
    mesai_bitis TIME
);
CREATE TABLE rooms (
    id SERIAL PRIMARY KEY ,
    room_number VARCHAR(10),
    capacity INTEGER,
    is_available BOOLEAN
);

CREATE TABLE reservations
(
    id         SERIAL PRIMARY KEY,
    room_id    INTEGER REFERENCES rooms (id),
    start_date DATE,
    end_date   DATE
);

