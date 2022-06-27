CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Employee" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Employee" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    "Email" TEXT NOT NULL,
    "Password" TEXT NOT NULL,
    "Cpf" TEXT NOT NULL,
    "Rg" TEXT NOT NULL,
    "Empresa" TEXT NOT NULL,
    "Telefone" TEXT NOT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220621023333_EmployeesMigration', '6.0.4');

COMMIT;

BEGIN TRANSACTION;

CREATE TABLE "Announcements" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Announcements" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NULL,
    "Subtitle" TEXT NULL,
    "createdAt" TEXT NULL
);

CREATE TABLE "ef_temp_Employee" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Employee" PRIMARY KEY AUTOINCREMENT,
    "Cpf" TEXT NULL,
    "Email" TEXT NULL,
    "Empresa" TEXT NULL,
    "Name" TEXT NULL,
    "Password" TEXT NULL,
    "Rg" TEXT NULL,
    "Telefone" TEXT NULL
);

INSERT INTO "ef_temp_Employee" ("Id", "Cpf", "Email", "Empresa", "Name", "Password", "Rg", "Telefone")
SELECT "Id", "Cpf", "Email", "Empresa", "Name", "Password", "Rg", "Telefone"
FROM "Employee";

COMMIT;

PRAGMA foreign_keys = 0;

BEGIN TRANSACTION;

DROP TABLE "Employee";

ALTER TABLE "ef_temp_Employee" RENAME TO "Employee";

COMMIT;

PRAGMA foreign_keys = 1;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220625210951_AnnouncementsMigration', '6.0.4');

COMMIT;

BEGIN TRANSACTION;

CREATE TABLE "PunchTheClock" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_PunchTheClock" PRIMARY KEY AUTOINCREMENT,
    "userId" INTEGER NOT NULL,
    "startedIn" TEXT NULL,
    "finishedIn" TEXT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220626221148_PunchTheClockMigration', '6.0.4');

COMMIT;

