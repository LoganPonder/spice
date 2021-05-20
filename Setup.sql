CREATE TABLE recipes (
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL,
    timeToMake INT NOT NULL,
    vegan TINYINT NOT NULL,
    vegetarian TINYINT NOT NULL,
    PRIMARY KEY (id)
);

-- CREATE TABLE ingredients (
--     id INT NOT NULL AUTO_INCREMENT,
--     creatorId VARCHAR(255) NOT NULL,
--     title VARCHAR(255) NOT NULL,
--     amount VARCHAR(255) NOT NULL,
--     PRIMARY KEY (id),
--     FOREIGN KEY (creatorId)
--     REFERENCES recipes(id)
--     ON DELETE CASCADE
-- );
