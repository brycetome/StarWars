PGDMP                  	    |        
   StarWarsDB    16.4 (Debian 16.4-1.pgdg120+1)    16.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                        0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            !           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            "           1262    16385 
   StarWarsDB    DATABASE     w   CREATE DATABASE "StarWarsDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';
    DROP DATABASE "StarWarsDB";
                sa    false            �            1259    16392    Starship    TABLE     �  CREATE TABLE public."Starship" (
    "Id" integer NOT NULL,
    "MGLT" text NOT NULL,
    cargo_capacity text NOT NULL,
    consumables text NOT NULL,
    cost_in_credits text NOT NULL,
    created timestamp with time zone,
    crew integer NOT NULL,
    edited timestamp with time zone,
    hyperdrive_rating double precision NOT NULL,
    length double precision NOT NULL,
    manufacturer text NOT NULL,
    max_atmosphering_speed text NOT NULL,
    model text NOT NULL,
    name text NOT NULL,
    passengers integer NOT NULL,
    films text[] NOT NULL,
    pilots text[] NOT NULL,
    starship_class text NOT NULL,
    url text NOT NULL
);
    DROP TABLE public."Starship";
       public         heap    sa    false            �            1259    16391    Starship_Id_seq    SEQUENCE     �   ALTER TABLE public."Starship" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Starship_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          sa    false    217            �            1259    16386    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    sa    false                      0    16392    Starship 
   TABLE DATA           �   COPY public."Starship" ("Id", "MGLT", cargo_capacity, consumables, cost_in_credits, created, crew, edited, hyperdrive_rating, length, manufacturer, max_atmosphering_speed, model, name, passengers, films, pilots, starship_class, url) FROM stdin;
    public          sa    false    217   	                 0    16386    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          sa    false    215   &       #           0    0    Starship_Id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Starship_Id_seq"', 1, false);
          public          sa    false    216            �           2606    16398    Starship PK_Starship 
   CONSTRAINT     X   ALTER TABLE ONLY public."Starship"
    ADD CONSTRAINT "PK_Starship" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Starship" DROP CONSTRAINT "PK_Starship";
       public            sa    false    217            �           2606    16390 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            sa    false    215                  x������ � �         1   x�320214043�4�00����,�L�q.JM,I��3�34������ މ
)     