PGDMP      ,                |            usecase    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24699    usecase    DATABASE     ~   CREATE DATABASE usecase WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE usecase;
                postgres    false            �            1259    24751    userbase    TABLE     /  CREATE TABLE public.userbase (
    id integer NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(255) NOT NULL,
    email character varying(255) NOT NULL,
    role character varying(50) NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
    DROP TABLE public.userbase;
       public         heap    postgres    false            �            1259    24750    userbase_id_seq    SEQUENCE     �   CREATE SEQUENCE public.userbase_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.userbase_id_seq;
       public          postgres    false    216            �           0    0    userbase_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.userbase_id_seq OWNED BY public.userbase.id;
          public          postgres    false    215            P           2604    24754    userbase id    DEFAULT     j   ALTER TABLE ONLY public.userbase ALTER COLUMN id SET DEFAULT nextval('public.userbase_id_seq'::regclass);
 :   ALTER TABLE public.userbase ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    215    216            �          0    24751    userbase 
   TABLE DATA           S   COPY public.userbase (id, username, password, email, role, created_at) FROM stdin;
    public          postgres    false    216   �       �           0    0    userbase_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.userbase_id_seq', 17, true);
          public          postgres    false    215            S           2606    24763    userbase userbase_email_key 
   CONSTRAINT     W   ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_email_key UNIQUE (email);
 E   ALTER TABLE ONLY public.userbase DROP CONSTRAINT userbase_email_key;
       public            postgres    false    216            U           2606    24759    userbase userbase_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.userbase DROP CONSTRAINT userbase_pkey;
       public            postgres    false    216            W           2606    24761    userbase userbase_username_key 
   CONSTRAINT     ]   ALTER TABLE ONLY public.userbase
    ADD CONSTRAINT userbase_username_key UNIQUE (username);
 H   ALTER TABLE ONLY public.userbase DROP CONSTRAINT userbase_username_key;
       public            postgres    false    216            �      x������ � �     