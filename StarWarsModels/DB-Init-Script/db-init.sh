createdb -U sa StarWarsDB

pg_restore -d StarWarsDB -U sa /data/StarWarsDBBackup.sql