DROP TABLE IF EXISTS "MeaningOfLife";
CREATE TABLE "MeaningOfLife" (
    "Id" SERIAL PRIMARY KEY,
    "Answer" TEXT NOT NULL,
    "Description" TEXT NOT NULL
);
INSERT INTO "MeaningOfLife" ("Id", "Answer", "Description")
VALUES (
        1,
        '42',
        'The Answer to Life, the Universe and Everything'
    );